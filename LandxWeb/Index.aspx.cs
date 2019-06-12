using LandxWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LandxWeb
{
	public partial class Index : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSearch_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtSearch.Text))
			{
				using (var db = new LandxEntities())
				{
					string searchText = txtSearch.Text.Trim().ToLower();
					if (searchText.StartsWith("land"))
					{
						int id;
						try
						{
							id = Convert.ToInt32(searchText.Replace("land", "").Trim());
						}
						catch (Exception)
						{
							litError.Text= "The Input text is not a valid ID.";
							return;
						}
						Models.Land land = db.Lands.Find(id);
						if (land == null)
						{
							litError.Text = "No land was found with this ID.";
							return;
						}
						else
						{
							panFound.Visible = true;
							litDescription.Text = land.LandDescription;
							litId.Text = searchText;
							litOwnerName.Text = land.Person.ApplicantsFullname;
							litPhone.Text = land.Person.PhoneNumber;
						}
					}
				}
			}
		}
	}
}