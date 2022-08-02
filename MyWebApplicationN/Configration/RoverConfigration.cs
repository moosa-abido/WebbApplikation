using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebApplicationN.Models;

namespace MyWebApplicationN.Configration
{
    public class RoverConfigration : IEntityTypeConfiguration<Rover>
    {
        public void Configure(EntityTypeBuilder<Rover> builder)
        {
            builder.HasData(new Rover
            {
                Id = 1,
                Name = "Spirit",
                Description = "Spirit, also known as MER-A (Mars Exploration Rover – A) or MER-2, was NASA's first probe in the Mars Exploration Rover Mission. It was launched by a Delta II rocket from Cape Canaveral Air Force Station, on 10 June 2003 and landed on the Martian surface on January 3, 2004. The mission was intended to last 90 days, but thanks to the occasional blowing of the solar cells by strong Martian winds, Spirit survived for 2,269 days. covered it a total of 7.73 kilometers"
            },
                    new Rover

                    {
                        Id = 2,
                        Name = "Opportunity",
                        Description = "Opportunity, also known as MER-B (Mars Exploration Rover – B) or MER-1 was NASA's second space probe in the Mars Exploration Rover Mission program. MER-B was launched on a Delta II rocket from Cape Canaveral Air Force Station on July 8, 2003 and landed in the Meridiani planum region of the planet Mars on January 25, 2004. On February 13, 2019, NASA declared the mission complete as it had not since June 2018 had contact with the craft. This after a larger sandstorm moved across the area where it was located. Opportunity was active for a full 15 years and 19 days, even though the mission is only planned to last 90 days."
                    },
                       new Rover

                       {
                           Id = 3,
                           Name = "Curiosity",
                           Description = "Curiosity (Mars Science Laboratory, abbreviated MSL) is an unmanned motorized lander (rover) that was launched by an Atlas V 541 rocket from Cape Canaveral Air Force Station on November 26, 2011. According to plan, the rover landed on Mars at Gale Crater on 5 August 2012. The rover is three times as heavy and twice as wide as the previous Mars Exploration Rovers (MER) Spirit and Opportunity. The rover was expected at launch to operate for at least one Martian year (about two Earth years) and was planned to be the rover that covered a larger portion of the planet's surface than any previous rover. The mission was to investigate Mars' past and present ability to harbor life. In 2021, Curiosity is still active, which means it has survived far longer than first thought or planned for."
                       }

                 );
        }
    }
}
