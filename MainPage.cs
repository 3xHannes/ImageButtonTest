namespace ImageButtonTest
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            ImageSource fileImageSource = "Test1.png";
            ImageSource streamImageSource = ImageSource.FromResource("Test2.png", typeof(MainPage).Assembly);

            Content = new ImageButton { Source = fileImageSource, Aspect = Aspect.AspectFit };
        }
    }
}