using System;

namespace ClassLibraryFacultatives
{
    public class AdressInfo
    {
        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; } = "";

        /// <summary>
        /// Дом
        /// </summary>
        public string House { get; set; } = "";

        /// <summary>
        /// Квартира
        /// </summary>
        public string Flat { get; set; } = "";

        public override string ToString()
        {
            return $"{Street} {House} {Flat}";
        }
    }
}