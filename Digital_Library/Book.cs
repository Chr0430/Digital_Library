namespace Digital_Library
{
    //书籍类
    public class Book
    {
        public int ID { get; set; }          // 书籍ID
        public string CoverImage { get; set; } // 封面的文件名
        public string BookName { get; set; } // 书名
        public string Author { get; set; }   // 作者
        public string PublicationDate { get; set; }   // 出版日期
        public string Type { get; set; }   // 种类
        public string ReturnTime { get; set; }   // 归还时间
        public int RemainingTime { get; set; } // 剩余天数
    }
}