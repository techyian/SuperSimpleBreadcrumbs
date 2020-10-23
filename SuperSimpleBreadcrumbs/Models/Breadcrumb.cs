namespace SuperSimpleBreadcrumbs.Models
{
    public class Breadcrumb
    {
        public string Text { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public bool Active { get; set; }

        public Breadcrumb() { }

        public Breadcrumb(string text, string action, string controller, bool active)
        {
            this.Text = text;
            this.Action = action;
            this.Controller = controller;
            this.Active = active;
        }
    }
}