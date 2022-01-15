using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;

namespace indice.Edi.Tests.Models
{
    public class Edifact_SeatMap
    {
        public Message Msg { get; set; }

        [EdiMessage]
        public class Message
        {
            public CBD CabinDetails { get; set; }
            public List<ROD> RowDetails { get; set; }
        }

        /// <summary>
        /// Row Details
        /// </summary>
        [EdiSegment, EdiPath("ROD")]
        public class ROD
        {
            [EdiValue(Path = "*/0")]
            public string SeatRowNumber { get; set; }

            [EdiPath("*/1")]
            public ROD_RowCharacteristicsDetails RowCharacteristicsDetails { get; set; }

            //public List<ROD_SeatOccupationDetails> SeatOccupationDetails { get; set; }
        }

        /// <summary>
        /// C049
        /// </summary>
        [EdiElement]
        public class ROD_RowCharacteristicsDetails
        {
            [EdiValue(Path = "*/1/0")]
            public string RowCharacteristic { get; set; }
            [EdiValue(Path = "*/1/1")]
            public string RowCharacteristic1 { get; set; }
            [EdiValue(Path = "*/1/2")]
            public string RowCharacteristic2 { get; set; }

            [EdiValue(Path = "*/1/3")]
            public string RowCharacteristic3 { get; set; }
            [EdiValue(Path = "*/1/4")]
            public string RowCharacteristic4 { get; set; }
            [EdiValue(Path = "*/1/5")]
            public string RowCharacteristic5 { get; set; }
            [EdiValue(Path = "*/1/6")]
            public string RowCharacteristic6 { get; set; }
            [EdiValue(Path = "*/1/7")]
            public string RowCharacteristic7 { get; set; }
            [EdiValue(Path = "*/1/8")]
            public string RowCharacteristic8 { get; set; }

        }

        /// <summary>
        /// C051
        /// </summary>
        [EdiElement]
        public class ROD_SeatOccupationDetails
        {
            [EdiValue(Path = "*/*/0")]
            public string SeatColumn { get; set; }
            [EdiValue(Path = "*/*/1")]
            public string SeatOccupation { get; set; }
            [EdiValue(Path = "*/*/2")]
            public string SeatCharacteristicCoded { get; set; }

            [EdiValue(Path = "*/*/3")]
            public string SeatCharacteristicCoded1 { get; set; }
            [EdiValue(Path = "*/*/4")]
            public string SeatCharacteristicCoded2 { get; set; }
            [EdiValue(Path = "*/*/5")]
            public string SeatCharacteristicCoded3 { get; set; }
            [EdiValue(Path = "*/*/6")]
            public string SeatCharacteristicCoded4 { get; set; }
            [EdiValue(Path = "*/*/7")]
            public string SeatCharacteristicCoded5 { get; set; }
            [EdiValue(Path = "*/*/8")]
            public string SeatCharacteristicCoded6 { get; set; }

            //there are 30 more record

        }

        //CabinDetails
        /// <summary>
        /// Cabin Details
        /// </summary>
        [EdiSegment, EdiPath("CBD")]
        public class CBD
        {

            [EdiPath("*/0")]
            public CBD_CabinClassDesignation CabinClassDesignation { get; set; }

            [EdiPath("*/1")]
            public CBD_CabinClassSeatRowRangeDetails CabinClassSeatRowRangeDetails { get; set; }

            [EdiValue(Path = "*/2")]
            public string CabinClassLocation { get; set; }

            [EdiPath("*/3")]
            public CBD_SmokingAreaSeatRowRangeDetails SmokingAreaSeatRowRangeDetails { get; set; }

            [EdiValue(Path = "*/4")]
            public string SeatOccupationDefaultIndicator { get; set; }

            [EdiPath("*/5")]
            public CBD_OverwingSeatRowRange OverwingSeatRowRange { get; set; }

            //public List<CBD_CabinWidthAndColumnDetails> CabinWidthAndColumnDetails { get; set; }


        }

        /// <summary>
        /// C342
        /// </summary>
        [EdiElement]
        public class CBD_CabinClassDesignation
        {
            [EdiValue(Path = "*/0/0")]
            public string CabinClassDesignator { get; set; }
            [EdiValue(Path = "*/0/1")]
            public string CharacteristicIdentification { get; set; }
            [EdiValue(Path = "*/0/2")]
            public string CabinClassOfServiceCoded { get; set; }

            [EdiValue(Path = "*/0/3")]
            public string CabinCompartmentDesignator { get; set; }

        }

        /// <summary>
        /// C052
        /// </summary>
        [EdiElement]
        public class CBD_CabinClassSeatRowRangeDetails
        {
            [EdiValue(Path = "*/1/0")]
            public string CabinClassDesignator { get; set; }
            [EdiValue(Path = "*/1/1")]
            public string CharacteristicIdentification { get; set; }

        }

        /// <summary>
        /// C053
        /// </summary>
        [EdiElement]
        public class CBD_SmokingAreaSeatRowRangeDetails
        {
            [EdiValue(Path = "*/3/0")]
            public string SeatRowNumber { get; set; }
            [EdiValue(Path = "*/3/1")]
            public string SeatRowNumber1 { get; set; }

        }

        /// <summary>
        /// C058
        /// </summary>
        [EdiElement]
        public class CBD_OverwingSeatRowRange
        {
            [EdiValue(Path = "*/5/0")]
            public string SeatRowNumber { get; set; }
            [EdiValue(Path = "*/5/1")]
            public string SeatRowNumber1 { get; set; }

        }

        /// <summary>
        /// C054
        /// </summary>
        [EdiElement]
        public class CBD_CabinWidthAndColumnDetails
        {
            [EdiValue(Path = "*/*/0")]
            public string SeatColumn { get; set; }
            [EdiValue(Path = "*/*/1")]
            public string ColumnDescription { get; set; }
            [EdiValue(Path = "*/*/2")]
            public string ColumnDescription1 { get; set; }

        }
    }
}
