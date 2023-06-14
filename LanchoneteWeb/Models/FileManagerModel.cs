namespace LanchoneteWeb.Models
{
    public class FileManagerModel
    {
        public FileInfo[] Files { get; set; }
        public IFormFile IFormFile { get; set; }
        public List<IFormFile> IFormeFiles { get; set; }
        public string PathImagesProduto { get; set; }
    }
}
