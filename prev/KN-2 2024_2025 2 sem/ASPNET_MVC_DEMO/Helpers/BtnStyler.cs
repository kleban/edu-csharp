namespace ASPNET_MVC_DEMO.Helpers
{
    public static class BtnStyler
    {
        private readonly static string[] _btns = new string[]
        {
                "btn btn-outline-primary",
                "btn btn-outline-secondary",
                "btn btn-outline-success",
                "btn btn-outline-danger",
                "btn btn-outline-warning",
                "btn btn-outline-info",
                "btn btn-outline-dark"
        };
        private static readonly Random rnd = new Random();
        public static string GetRndStyle()
        {
            return _btns[rnd.Next(0, _btns.Length)];
        }
    }
}
