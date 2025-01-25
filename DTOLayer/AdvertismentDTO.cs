using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class AdvertismentDTO:BaseDTO
    {
        public long? Id { get; set; }
        public string JobName { get; set; } = null!;
        public long AdvertismentCatId { get; set; }
        public int CityId { get; set; }
        /// <summary>
        /// خانم 1//
        /// آقا 2//
        /// خانم/آقا 0
        /// </summary>
        public int Gender { get; set; }
        public string Rights { get; set; } = null!;
        public string MilitaryStatus { get; set; } = null!;
        public int MinHistory { get; set; }
        public string? MinimumEducationDegree { get; set; }
        public string? Desc { get; set; }
        public bool IsConfirm { get; set; }

        public string? AdvertismentCatname { get; set; }
        public string? CityName { get; set; }

        public long? UserID { get; set; }

    }
}
