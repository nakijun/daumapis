import responses.*;


public class TestConsole {

		public static void main(String[] args) throws Exception
		{
			BlogData data = OpenApiProvider.requestBlogApi("7fd190dd37f0ad9d15cbfd69e6d1aa3320623256", "apple", 10, 1, "accu", "rss", "");
			
			System.out.print(data);
		}
}
