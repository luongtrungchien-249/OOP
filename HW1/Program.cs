internal class Program
{
     public string Name { get; set; }
     public int MaSV { get; set; }
     public string Class { get; set; }
     public string UsernameGIT { get; set; }
     public string EmailAddress { get; set; }

     public Information() 
     {
         Name = " Lương Trung Chiến ";
         MaSV = 12424042;
         Class = "12424TN";
         UsernameGIT = "luongtrungchien-249";
         EmailAddress = "luongtrungchienox@gmail.com";
     }
     public void hienThi()
     {
         Console.WriteLine($" Họ tên : { Name } \t \t Mã sinh viên : { MaSV } \t \t Lớp : { Class } \t \t Username : { UsernameGIT } \t \t Email : { EmailAddress }");
     }
    
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Information infor = new Information();
        infor.hienThi();
    }
}
