using System;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;

// 连接数据库部分模块化代码
public class MySQLConnect
{
    // 数据库连接配置
    private readonly string _host; //MySQL服务器 IP
    private readonly string _port; //端口
    private readonly string _user; //用户名
    private readonly string _password; //密码
    private readonly string _database; //数据库名

    /// <summary>
    /// 数据库连接参数默认从 App.config 读取（统一入口见 AppConfig），
    /// 调用方直接 new MySQLConnect() 即可；确需连接其它库时再显式传参覆盖。
    /// </summary>
    public MySQLConnect(string host = null, string port = null, string user = null, string password = null, string database = null)
    {
        _host = host ?? AppConfig.DbHost;
        _port = port ?? AppConfig.DbPort;
        _user = user ?? AppConfig.DbUser;
        _password = password ?? AppConfig.DbPassword;
        _database = database ?? AppConfig.DbName;
    }

    /// <summary>
    /// 构建 MySQL 数据库连接字符串
    /// </summary>
    /// <returns>完整的连接字符串</returns>
    private string GetConnectionString()
    {
        return $"server={_host};port={_port};user id={_user};password={_password};database={_database};charset=utf8mb4;";
    }

    /// <summary>
    /// 执行查询 SQL 语句，返回 DataTable 类型结果
    /// </summary>
    /// <param name="sql">要执行的查询 SQL 语句</param>
    /// <returns>查询结果（DataTable类型）</returns>
    /// <exception cref="Exception">数据库操作异常</exception>
    public DataTable ExecuteQuery(string sql)
    {
        DataTable resultTable = new DataTable();

        // 使用 using 自动释放连接资源
        using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
        {
            try
            {
                // 连接数据库
                conn.Open();

                // 执行 SQL 语句查询
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(resultTable); // 填充结果到 DataTable
                }
            }
            catch (Exception ex)
            {
                // 抛出异常
                throw new Exception($"数据库查询失败：{ex.Message}", ex);
            }
            finally
            {
                // 关闭数据库连接
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        //返回查询结果
        return resultTable;
    }

    /// <summary>
    /// 执行参数化查询 SQL 语句，返回 DataTable 类型结果。
    /// SQL 中使用 @参数名 占位，值统一通过 parameters 传入，避免字符串拼接带来的 SQL 注入风险。
    /// </summary>
    /// <param name="sql">要执行的查询 SQL 语句（含 @参数 占位符）</param>
    /// <param name="parameters">参数集合</param>
    /// <returns>查询结果（DataTable类型）</returns>
    /// <exception cref="Exception">数据库操作异常</exception>
    public DataTable ExecuteQuery(string sql, params MySqlParameter[] parameters)
    {
        DataTable resultTable = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
        {
            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable); // 填充结果到 DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"数据库查询失败：{ex.Message}", ex);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        return resultTable;
    }

    /// <summary>
    /// 执行更新/插入/删除 SQL 语句（UPDATE/INSERT/DELETE）
    /// </summary>
    /// <param name="sql">要执行的 SQL 语句</param>
    /// <returns>受影响的行数（更新成功返回 >=1，无匹配行返回 0）</returns>
    /// <exception cref="Exception">数据库操作异常</exception>
    public int ExecuteNonQuery(string sql)
    {
        int affectedRows = 0; // 受影响的行数

        using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    affectedRows = cmd.ExecuteNonQuery(); // 执行更新，返回受影响行数
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"数据库更新失败：{ex.Message}", ex);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        return affectedRows;
    }

    /// <summary>
    /// 执行参数化更新/插入/删除 SQL 语句（UPDATE/INSERT/DELETE）。
    /// SQL 中使用 @参数名 占位，值统一通过 parameters 传入，避免字符串拼接带来的 SQL 注入风险。
    /// </summary>
    /// <param name="sql">要执行的 SQL 语句（含 @参数 占位符）</param>
    /// <param name="parameters">参数集合</param>
    /// <returns>受影响的行数（更新成功返回 >=1，无匹配行返回 0）</returns>
    /// <exception cref="Exception">数据库操作异常</exception>
    public int ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
    {
        int affectedRows = 0;

        using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
        {
            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    affectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"数据库更新失败：{ex.Message}", ex);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        return affectedRows;
    }

    /// <summary>
    /// 构造查询参数，并自动把 null 转为 DBNull，供参数化 SQL 使用。
    /// 用法：MySQLConnect.Param("@name", name)
    /// </summary>
    /// <param name="name">参数名（含 @ 前缀）</param>
    /// <param name="value">参数值</param>
    /// <returns>MySqlParameter 对象</returns>
    public static MySqlParameter Param(string name, object value)
    {
        return new MySqlParameter(name, value ?? DBNull.Value);
    }

    /// <summary>
    /// 测试数据库连接是否可用
    /// </summary>
    /// <returns>连接成功返回 true，失败返回 false</returns>
    public bool TestConnection()
    {
        using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}