using Ninject;
using Ninject.Web;
using System;
using System.Configuration;

using RoadTakenDemo.Abstractions;

namespace RoadTakenDemo
{
    public partial class Demo : PageBase
    {
        [Inject]
        public IDemoFacade Facade {  get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            litFirstNumber.Text = ConfigurationManager.AppSettings["FirstNumber"];
            if (!IsPostBack)
            {
                txtSecondNumber.Text = "0";
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            var intFirstNumber = Int32.Parse(litFirstNumber.Text);
            var intSecondNumber = Int32.Parse(txtSecondNumber.Text);
            var model = Facade.AddNumbers(intFirstNumber, intSecondNumber);
            litResult.Text = model.Result.ToString();
        }
    }
}