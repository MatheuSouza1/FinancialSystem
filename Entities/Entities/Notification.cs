using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Notification
    {
        [NotMapped]
        public string PropName { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notification> Notifications { get; set; }

        public Notification() 
        {
            Notifications = new List<Notification>();
        }

        public bool ValidateStringProp(string value, string propName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propName)){
                Notifications.Add(new Notification
                {
                    Message = "Campo Obrigatório",
                    PropName = propName
                });

                return false;
            }
            return true;
        }

        public bool ValidateIntProp(int value, string propName)
        {
            if(value < 1 || string.IsNullOrWhiteSpace(propName))
            {
                Notifications.Add(new Notification
                {
                    Message = "Campo Obrigatório",
                    PropName = propName
                });

                return false;
            }
            return true;
        }
    }
}
