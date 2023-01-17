using ListViews.Service.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Service.Common_Services
{
    public class ModelDataAnnotationCheck : IModelDataAnnotationCheck
    {
        public void ValidateModelDataAnnotations<TDomainModel>(TDomainModel domainModel)
        {
            ICollection<ValidationResult> validationResultList = new List<ValidationResult>();

            ValidationContext validationContext = new ValidationContext(domainModel, null, null);

            StringBuilder stringBuilder= new StringBuilder();

            if (!Validator.TryValidateObject(domainModel, validationContext, validationResultList,true))
            {
                foreach(ValidationResult validationResult in validationResultList)
                {
                    stringBuilder
                        .Append(validationResult.ErrorMessage.ToString())
                        .AppendLine(); 
                }
            }
            if(validationResultList.Count > 0)
            {
                throw new ArgumentException(stringBuilder.ToString());
            }
        }
    }
}
