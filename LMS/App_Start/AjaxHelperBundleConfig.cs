using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(LMS.App_Start.AjaxHelperBundleConfig), "RegisterBundles")]

namespace LMS.App_Start
{
	public class AjaxHelperBundleConfig
	{
		public static void RegisterBundles()
		{
			BundleTable.Bundles.Add(new ScriptBundle("~/bundles/ajaxhelper").Include("~/Scripts/jquery.ajaxhelper.js"));
		}
	}
}