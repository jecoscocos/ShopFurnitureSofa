
using System.Web.Optimization;


namespace ShopFurniture.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Home style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/Content/bootstrap.css", new CssRewriteUrlTransform()));

            // Animate.css
            bundles.Add(new StyleBundle("~/bundles/animate/css").Include(
                      "~/Content/animate.css"));

            // Pe-icon-7-stroke
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                      "~/Content/font-awesome.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/ion-range-slider/css").Include(
                     "~/Content/ion-range-slider.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/linear-icons/css").Include(
                     "~/Content/linear-icons.css", new CssRewriteUrlTransform()));

            // Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/magnific-popup/css").Include(
                      "~/Content/magnific-popup.css", new CssRewriteUrlTransform()));

            // Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/owl.carousel/css").Include(
                      "~/Content/owl.carousel.css", new CssRewriteUrlTransform()));
            //Toaster
            bundles.Add(new StyleBundle("~/bundles/theme/css").Include(
                      "~/Vendors/theme.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/iquery/js").Include(
          "~/Scripts/iquery.min.js"));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                      "~/Scripts/bootstrap.js"));

            // Unobtrusive           
            bundles.Add(new ScriptBundle("~/bundles/ion.rangeSlider/js").Include(
                      "~/Scripts/ion.rangeSlider.js"));

            // Pace
            bundles.Add(new ScriptBundle("~/bundles/magnific-popup/js").Include(
                      "~/Scripts/magnific-popup.js"));

            // Luna
            bundles.Add(new ScriptBundle("~/bundles/owl.carousel/js").Include(
                      "~/Scripts/owl.carousel.js"));

            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/tilt.jquery/js").Include(
                      "~/Scripts/tilt.jquery.js"));
            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/jquery.easypiechart/js").Include(
                      "~/Scripts/jquery.easypiechart.js"));
            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/bigtext/js").Include(
                      "~/Scripts/bigtext.js"));
            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                      "~/Scripts/main.js"));


        }
    }
}