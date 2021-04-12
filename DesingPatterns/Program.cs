using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesingPatterns
{
    class Program
    {
        public static void Display(string s, IComponent c)
        {
            Console.WriteLine(s + c.Operation());
        }

        public static void Decorator()
        {
            Console.WriteLine("Decorator Pattern\n");
            IComponent component = new Component();
            Display("1. Basic component:", component);
            Display("2. A-decorated: ", new DecoratorA(component));
            Display("3. B-decorated: ", new DecoratorB(component));
            Display("4. BA decorated: ", new DecoratorB(new DecoratorA(component)));

            DecoratorB b = new DecoratorB(new Component());
            Display("5. AB decorated: ", new DecoratorA(b));
            Console.WriteLine(b.addedState + b.AddBehavior());

        }

        public static void DecoratorImage()
        {
            // Application.Run acts as a simple client
            Photo photo;
            TaggedPhoto foodTaggedPhoto, colorTaggedPhoto, tag;
            BorderedPhoto composition;
            // Compose a photo with two TaggedPhotos and a blue BorderedPhoto
            photo = new Photo();
            Application.Run(photo);
            foodTaggedPhoto = new TaggedPhoto(photo, "Food");
            colorTaggedPhoto = new TaggedPhoto(foodTaggedPhoto, "Yellow");
            composition = new BorderedPhoto(colorTaggedPhoto, Color.Blue);
            Application.Run(composition);
            Console.WriteLine(colorTaggedPhoto.ListTaggedPhotos());
            // Compose a photo with one TaggedPhoto and a yellow BorderedPhoto
            photo = new Photo();
            tag = new TaggedPhoto(photo, "Jug");
            composition = new BorderedPhoto(tag, Color.Yellow);
            Application.Run(composition);
            Console.WriteLine(tag.ListTaggedPhotos());
        }
        static void Main(string[] args)
        {
            //Decorator();
            DecoratorImage();
        }
    }
}
