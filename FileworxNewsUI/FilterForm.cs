using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileworxNewsBusiness;

namespace FileworxsNewsUI
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
            InitializeUsersList();
        }
        private void OnClickDateFilterChBox(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked == true)
            {
                comBoxDate.Visible = true;

            }
            else
            {
                HideDateFilterComponents();
            }
        }
        private void OnClickTitleFilterChBox(object sender, EventArgs e)
        {
            if (checkBoxTitle.Checked == true)
            {
                comBoxTitle.Visible = true;

            }
            else
            {
                comBoxTitle.SelectedItem = null;
                comBoxTitle.Visible = false;
            }
        }
        private void OnClickDescFilterChBox(object sender, EventArgs e)
        {
            if (checkBoxDescription.Checked == true)
            {
                comBoxDescription.Visible = true;

            }
            else
            {
                comBoxDescription.SelectedItem = null;
                comBoxDescription.Visible = false;
            }
        }
        private void OnClickCreatorFilterChBox(object sender, EventArgs e)
        {
            if (checkBoxCreator.Checked == true)
            {
                comboxCreator.Visible = true;

            }
            else
            {
                comboxCreator.Visible = false;
            }
        }
        private void OnClickLastModFilterChBox(object sender, EventArgs e)
        {
            if (checkBoxlastMod.Checked == true)
            {
                comboxLastMod.Visible = true;

            }
            else
            {
                comboxLastMod.Visible = false;
            }
        }
        private void ComBoxDateSelect(object sender, EventArgs e)
        {
            if (comBoxDate.SelectedItem != null
                && comBoxDate.SelectedItem.ToString() != "Today")
            {
                lblDateValue.Visible = true;
                datePickerValue.Visible = true;

                if (comBoxDate.SelectedItem.ToString() == "Date Range")
                {
                    lblDateValue.Text = "From";
                    lblToDate.Visible = true;
                    datePickerToValue.Visible = true;
                }
                else
                {
                    lblDateValue.Text = "Date";
                    lblToDate.Visible = false;
                    datePickerToValue.Visible = false;
                }
            }
        }
        private void ComBoxTitleSelect(object sender, EventArgs e)
        {
            if (comBoxTitle.SelectedItem != null)
            {
                txtTitle.Text = string.Empty;
                txtTitle.Visible = true;
            }
            else
            {
                txtTitle.Visible = false;
            }
        }
        private void ComBoxDescSelect(object sender, EventArgs e)
        {
            if (comBoxDescription.SelectedItem != null)
            {
                txtDescription.Text = string.Empty;
                txtDescription.Visible = true;
            }
            else
            {
                txtDescription.Visible = false;
            }
        }
        private void InitializeUsersList()
        {
            var userQuery = new AppUserQuery();
            var usresList = userQuery.Run();

            comboxCreator.DataSource = usresList;
            comboxCreator.DisplayMember = "Name";
            comboxCreator.ValueMember = "Id";

            comboxLastMod.DataSource = usresList;
            comboxLastMod.DisplayMember = "Name";
            comboxLastMod.ValueMember = "Id";
        }
        private void HideDateFilterComponents()
        {
            comBoxDate.Visible = false;
            comBoxDate.SelectedItem = null;
            lblDateValue.Visible = false;
            datePickerValue.Visible = false;
            lblToDate.Visible = false;
            datePickerToValue.Visible = false;
        }
        private void OnApplyButtonClick(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
        }
        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public ContentQuery CheckFilters()
        {
            var ContentQuery = new ContentQuery();

            if (checkBoxDate.Checked == true &&
                comBoxDate.SelectedItem != null)
            {
                var type = (DateFilter.DateFilterType)comBoxDate.SelectedIndex;

                ContentQuery.QCreationDate = new DateFilter()
                {
                    FilterType = type,
                    Value = datePickerValue.Value.Date,
                    EndDate = datePickerToValue.Value.Date
                };

            }

            if (checkBoxTitle.Checked == true
                && comBoxTitle.SelectedItem != null
                && !string.IsNullOrEmpty(txtTitle.Text))
            {
                var type = (StringFilter.StringFilterType)comBoxTitle.SelectedIndex;

                ContentQuery.QName = new StringFilter()
                {
                    FilterType = type,
                    Value = txtTitle.Text,

                };

            }

            if (checkBoxDescription.Checked == true
               && comBoxDescription.SelectedItem != null
               && !string.IsNullOrEmpty(txtDescription.Text))
            {
                var type = (StringFilter.StringFilterType)comBoxDescription.SelectedIndex;

                ContentQuery.QDescription = new StringFilter()
                {
                    FilterType = type,
                    Value = txtDescription.Text,
                };

            }

            if(checkBoxCreator.Checked == true
               && comboxCreator.SelectedItem != null)
            {
                if (Guid.TryParse(comboxCreator.SelectedValue.ToString(), out Guid creatorId))
                {
                    ContentQuery.QCreatorId = creatorId;
                }
            }

            if (checkBoxlastMod.Checked == true
              && comboxLastMod.SelectedItem != null)
            {
                if (Guid.TryParse(comboxLastMod.SelectedValue.ToString(), out Guid creatorId))
                {
                    ContentQuery.QLastModifierId = creatorId;
                }
            }

            return ContentQuery;
        }
    }
}
