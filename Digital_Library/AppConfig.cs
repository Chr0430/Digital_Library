using System;
using System.Configuration;
using System.IO;

/// <summary>
/// 全局配置读取入口。
/// 数据库连接参数、封面图片目录、AI 服务地址统一从这里读取，
/// 需要修改时只改 App.config 的 appSettings 节点，不必改动业务代码。
/// </summary>
public static class AppConfig
{
    /// <summary>封面图片目录的默认文件夹名（自动查找时使用）</summary>
    private const string ImageFolderName = "Digital_Library_Picture";

    /// <summary>自动向上查找目录的最大层数（bin\Debug 到仓库根目录一般不超过 6 层）</summary>
    private const int MaxSearchDepth = 6;

    /// <summary>读取配置项，未配置或为空白时返回默认值</summary>
    private static string Get(string key, string defaultValue)
    {
        string value = ConfigurationManager.AppSettings[key];
        return string.IsNullOrWhiteSpace(value) ? defaultValue : value.Trim();
    }

    /// <summary>数据库服务器地址</summary>
    public static string DbHost
    {
        get { return Get("DbHost", "127.0.0.1"); }
    }

    /// <summary>数据库端口</summary>
    public static string DbPort
    {
        get { return Get("DbPort", "3307"); }
    }

    /// <summary>数据库用户名</summary>
    public static string DbUser
    {
        get { return Get("DbUser", "user"); }
    }

    /// <summary>数据库密码</summary>
    public static string DbPassword
    {
        get { return Get("DbPassword", "user"); }
    }

    /// <summary>数据库名</summary>
    public static string DbName
    {
        get { return Get("DbName", "digital_library"); }
    }

    /// <summary>AI 服务（Ollama）的生成接口地址</summary>
    public static string OllamaEndpoint
    {
        get { return Get("OllamaEndpoint", "http://localhost:11434/api/generate"); }
    }

    private static string _imageFolder;
    private static readonly object _imageFolderLock = new object();

    /// <summary>
    /// 封面图片所在目录。
    /// 优先使用 App.config 中的 ImageFolder 配置（支持绝对路径，或相对程序目录的相对路径）；
    /// 未配置时自动从程序目录向上逐层查找名为 Digital_Library_Picture 的文件夹，
    /// 这样换机器、换目录都能直接用，不需要改代码。
    /// </summary>
    public static string ImageFolder
    {
        get
        {
            if (_imageFolder == null)
            {
                lock (_imageFolderLock)
                {
                    if (_imageFolder == null)
                    {
                        _imageFolder = ResolveImageFolder();
                    }
                }
            }
            return _imageFolder;
        }
    }

    /// <summary>
    /// 解析封面图片目录的实际路径
    /// </summary>
    private static string ResolveImageFolder()
    {
        string configured = Get("ImageFolder", string.Empty);

        // 配置了路径：绝对路径直接用，相对路径按程序所在目录展开
        if (!string.IsNullOrEmpty(configured))
        {
            if (Path.IsPathRooted(configured))
            {
                return configured;
            }
            return Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configured));
        }

        // 未配置：从程序目录向上逐层查找图片文件夹
        DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
        for (int depth = 0; depth < MaxSearchDepth && dir != null; depth++)
        {
            string candidate = Path.Combine(dir.FullName, ImageFolderName);
            if (Directory.Exists(candidate))
            {
                return candidate;
            }
            dir = dir.Parent;
        }

        // 都没找到：返回程序目录下的同名文件夹（不存在时由调用方提示）
        return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ImageFolderName);
    }
}
