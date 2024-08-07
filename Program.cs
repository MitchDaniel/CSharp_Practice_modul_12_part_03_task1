namespace CSharp_Practice_modul_12_part_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Copy(@"C:\Users\Brill\Desktop\2024_07_25_21_17_IMG_6063.JPG", @"C:\Users\Brill\Desktop\Новая папка\Новый текстовый документ.jpg");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public static void Copy(string originalParth, string newParth)
        {
            if (newParth is null) throw new ArgumentNullException();
            if (originalParth is null) throw new ArgumentNullException();
            if(!File.Exists(originalParth)) throw new FileNotFoundException();
            File.Copy(originalParth, newParth, true);
            FileInfo originalFile = new FileInfo(originalParth);
            FileInfo newFile = new FileInfo(newParth);
            if (originalFile.Length != newFile.Length) throw new Exception("Coppy error");
        }
    }
}
//Задание 1:
//Создайте приложение для копирования файлов. 
//Пользователь вводит путь к оригинальному файлу и путь к тому месту куда нужно скопировать файл. 
//Приложение должно сообщить об успешности или неуспешности операции.