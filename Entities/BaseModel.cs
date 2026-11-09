using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Entities
{
    public abstract class BaseModel : IDataErrorInfo
    {


        public string this[string columnName]
        {
            get
            {
                if (string.IsNullOrEmpty(columnName))
                    return string.Empty;

                PropertyDescriptor property =TypeDescriptor.GetProperties(this)[columnName];
                if (property == null)
                {
                    return string.Empty;
                }
                object value = property.GetValue(this);

                var context = new ValidationContext(this) { MemberName = columnName };

                var results = new List<ValidationResult>();

                bool isValid = Validator.TryValidateProperty(value, context, results);

                return isValid ? string.Empty : results[0].ErrorMessage;
            }
        }

        public List<ValidationResult> GetValidationResults()
        {
            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(this, context, results, validateAllProperties: true);
            return results;
        }

        public bool IsValid() 
        {
           return GetValidationResults().Count == 0 ;
            
        }

        public string Error
        {
            get
            {
                return string.Join(Environment.NewLine,
                GetValidationResults().Select(r => r.ErrorMessage));
            }
        }

    }
}
