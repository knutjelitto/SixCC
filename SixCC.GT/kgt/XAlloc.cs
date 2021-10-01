namespace SixCC.GT.kgt
{
	public static class XAlloc
    {
		public static byte[] xmalloc(int size)
		{
			throw new NotImplementedException();
		}
		
		public static string xtxtdup(string t)
		{
			throw new NotImplementedException();
		}
		
		public static string xstrdup(string t)
		{
			throw new NotImplementedException();
		}

		public static void xerror(string msg)
		{
			Console.WriteLine(msg);
			Environment.Exit(-42);
		}
    }
}
