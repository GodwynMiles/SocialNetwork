namespace SocialNetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post("Hello");
            post.Text = postText;
            post.ShowPost();
        }
    }
}
