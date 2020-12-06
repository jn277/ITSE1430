/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CharacterRoster.Web.Models
{
    public class CharacterModel
    {
        public CharacterModel ( object character )
        {
        }

        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string CharacterName { get; set; }
        public string CharacterRoster { get; set; }
        public string Profession { get; set; }
        public string Race { get; set; }
        public int Attributes { get; set; }
        public string Description { get; set; }

        internal object ToCharacter ()
        {
            throw new NotImplementedException();
        }
    }
}
