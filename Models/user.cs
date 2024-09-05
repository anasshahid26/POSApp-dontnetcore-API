namespace POSApp.API.Models
{
    public class user
    {
        public int id { get; set; }
        public string username  { get; set; }
        public byte[] passwordhash { get; set; }
        public byte[] psswordsalt { get; set; }


    }
}