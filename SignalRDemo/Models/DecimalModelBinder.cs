using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemo.Models
{
    /// <summary>
    /// For deserializing from an apparent "Int32" to a Decimal.
    /// </summary>
    /// <remarks>
    /// Source: http://stackoverflow.com/questions/5698984/default-asp-net-mvc-3-model-binder-doesnt-bind-decimal-propeties
    /// </remarks>
    public class DecimalModelBinder : DefaultModelBinder
    {
        #region Implementation of IModelBinder

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueProviderResult.AttemptedValue.Equals("N.aN") ||
                valueProviderResult.AttemptedValue.Equals("NaN") ||
                valueProviderResult.AttemptedValue.Equals("Infini.ty") ||
                valueProviderResult.AttemptedValue.Equals("Infinity") ||
                string.IsNullOrEmpty(valueProviderResult.AttemptedValue))
                return 0m;

            return valueProviderResult == null ? base.BindModel(controllerContext, bindingContext) : Convert.ToDecimal(valueProviderResult.AttemptedValue);
        }

        #endregion
    }
}