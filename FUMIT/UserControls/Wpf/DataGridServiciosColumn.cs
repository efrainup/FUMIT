using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace FUMIT.UserControls.Wpf
{
    class DataGridServiciosColumn : DataGridBoundColumn
    {
        public DataTemplate CellTemplate { get; set; }
        public DataTemplate CellEditingTemplate { get; set; }



        private FrameworkElement LoadTemplateContent(bool isEditing, object dataItem, DataGridCell cell)
        {
            DataTemplate template;
            DataTemplateSelector templateSelector;
            ChooseCellTemplateAndSelector(isEditing, out template, out templateSelector);
            if (template != null || templateSelector != null)
            {
                ContentPresenter contentPresenter = new ContentPresenter();
                BindingOperations.SetBinding(contentPresenter, ContentPresenter.ContentProperty, this.Binding);
                contentPresenter.ContentTemplate = template;
                contentPresenter.ContentTemplateSelector = templateSelector;
                return contentPresenter;
            }

            return null;
        }

        /// <summary>
        ///     Creates the visual tree that will become the content of a cell.
        /// </summary>
        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            return LoadTemplateContent(/* isEditing = */ false, dataItem, cell);
        }

        /// <summary>
        ///     Creates the visual tree that will become the content of a cell.
        /// </summary>
        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem)
        {
            return LoadTemplateContent(/* isEditing = */ true, dataItem, cell);
        }
        /// <summary>
        ///     Returns either the specified CellTemplate[Selector] or CellEditingTemplate[Selector].
        ///     CellTemplate[Selector] is the fallack if CellEditingTemplate[Selector] is null.
        /// </summary>
        /// <param name="isEditing">Whether the editing template is requested.</param>
        private void ChooseCellTemplateAndSelector(bool isEditing, out DataTemplate template, out DataTemplateSelector templateSelector)
        {
            template = null;
            templateSelector = null;

            if (isEditing)
            {
                template = CellEditingTemplate;
                //templateSelector = CellEditingTemplateSelector;
            }

            if (template == null && templateSelector == null)
            {
                template = CellTemplate;
                //templateSelector = CellTemplateSelector;
            }
        }

    }
}
