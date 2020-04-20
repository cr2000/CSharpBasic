    using System;
//Task 1

//Create a class "PhotoAlbum" with a private attribute "numberOfPages".

//It should also have a public method "GetNumberOfPages", which will return the number of pages.

//The default constructor will create an album with 16 pages.There will be an additional constructor, with which we can specify the number of pages we want in the album.

//Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.

//In main method create a "PhotoAlbum" instance with its default constructor and one with 24 pages.Also create "BigPhotoAlbum" and show the number of pages that the three albums have.



namespace Task01
{
    public class BigPhotoAlbum
    {

        private int NumberOfPages;

        public BigPhotoAlbum()
        {
            NumberOfPages = 64;
        }

        public void GetNumberOfPages()
        {


            Console.WriteLine($"I have {NumberOfPages} pages. :)");
        }
    }


    public class PhotoAlbum
    {

        public PhotoAlbum()
        {
            NumberOFPages = 16;
        }

        public PhotoAlbum(int numberOFPages)
        {
            NumberOFPages = numberOFPages;
        }


        private int NumberOFPages;
      
        public void GetNumberOfPages()
        {
            Console.WriteLine($"I have {NumberOFPages} pages. :)");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            var photoAlbum1 = new PhotoAlbum();
            photoAlbum1.GetNumberOfPages();

            var photoAlbum2 = new PhotoAlbum(24);
            photoAlbum2.GetNumberOfPages();

            var bigPhotoAlbum = new BigPhotoAlbum();
            bigPhotoAlbum.GetNumberOfPages();



            Console.ReadLine();
        }
    }
}