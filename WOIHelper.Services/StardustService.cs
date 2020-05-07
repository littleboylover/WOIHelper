using System.Collections.Generic;
using System.Linq;
using WOIHelper.Data.Models;

namespace WOIHelper.Services
{
    public class StardustService
    {
        private List<Stardust> _stardusts;

        public StardustService()
        {
            PopulateStardusts();
        }

        private void PopulateStardusts()
        {
            _stardusts = new List<Stardust>
            {
                new Stardust("Strength Stardust LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Intellect Stardust LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Vitality Stardust LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Spirit Stardust LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Dexterity Stardust LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of HP LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of MP LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Physical Defense LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Magic Defense LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Accuracy LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Evasion LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Physical Attack LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Magic Attack LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Fire Resistance LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Ice Resistance LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Dark Resistance LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Stardust of Light Resistance LV1", new[]
                {
                    new Requirement("Crystal", 5, true),
                    new Requirement("Sealed Stardust", 1)
                }),
                new Stardust("Strength Stardust LV2", new[]
                {
                    new Requirement("Strength Stardust LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Intellect Stardust LV2", new[]
                {
                    new Requirement("Intellect Stardust LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Vitality Stardust LV2", new[]
                {
                    new Requirement("Vitality Stardust LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Spirit Stardust LV2", new[]
                {
                    new Requirement("Spirit Stardust LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Dexterity Stardust LV2", new[]
                {
                    new Requirement("Dexterity Stardust LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of HP LV2", new[]
                {
                    new Requirement("Stardust of HP LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of MP LV2", new[]
                {
                    new Requirement("Stardust of MP LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Physical Defense LV2", new[]
                {
                    new Requirement("Stardust of Physical Defense LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Magic Defense LV2", new[]
                {
                    new Requirement("Stardust of Magic Defense LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Accuracy LV2", new[]
                {
                    new Requirement("Stardust of Accuracy LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Evasion LV2", new[]
                {
                    new Requirement("Stardust of Evasion LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Physical Attack LV2", new[]
                {
                    new Requirement("Stardust of Physical Attack LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Magic Attack LV2", new[]
                {
                    new Requirement("Stardust of Magic Attack LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Fire Resistance LV2", new[]
                {
                    new Requirement("Stardust of Fire Resistance LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Ice Resistance LV2", new[]
                {
                    new Requirement("Stardust of Ice Resistance LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Dark Resistance LV2", new[]
                {
                    new Requirement("Stardust of Dark Resistance LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Stardust of Light Resistance LV2", new[]
                {
                    new Requirement("Stardust of Light Resistance LV1", 1),
                    new Requirement("Quartz", 10, true),
                    new Requirement("Starsoul Stone", 1)
                }),
                new Stardust("Strength Stardust LV3", new[]
                {
                    new Requirement("Strength Stardust LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Intellect Stardust LV3", new[]
                {
                    new Requirement("Intellect Stardust LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Vitality Stardust LV3", new[]
                {
                    new Requirement("Vitality Stardust LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Spirit Stardust LV3", new[]
                {
                    new Requirement("Spirit Stardust LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Dexterity Stardust LV3", new[]
                {
                    new Requirement("Dexterity Stardust LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of HP LV3", new[]
                {
                    new Requirement("Stardust of HP LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of MP LV3", new[]
                {
                    new Requirement("Stardust of MP LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Physical Defense LV3", new[]
                {
                    new Requirement("Stardust of Physical Defense LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Magic Defense LV3", new[]
                {
                    new Requirement("Stardust of Magic Defense LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Accuracy LV3", new[]
                {
                    new Requirement("Stardust of Accuracy LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Evasion LV3", new[]
                {
                    new Requirement("Stardust of Evasion LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Physical Attack LV3", new[]
                {
                    new Requirement("Stardust of Physical Attack LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Magic Attack LV3", new[]
                {
                    new Requirement("Stardust of Magic Attack LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Fire Resistance LV3", new[]
                {
                    new Requirement("Stardust of Fire Resistance LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Ice Resistance LV3", new[]
                {
                    new Requirement("Stardust of Ice Resistance LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Dark Resistance LV3", new[]
                {
                    new Requirement("Stardust of Dark Resistance LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Stardust of Light Resistance LV3", new[]
                {
                    new Requirement("Stardust of Light Resistance LV2", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 1)
                }),
                new Stardust("Super Stardust of HP LV3", new[]
                {
                    new Requirement("Stardust of HP LV3", 5),
                    new Requirement("Crystal Sphere", 5),
                    new Requirement("Sacred Particles", 20)
                }),
                new Stardust("Strength Stardust LV4", new[]
                {
                    new Requirement("Strength Stardust LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Intellect Stardust LV4", new[]
                {
                    new Requirement("Intellect Stardust LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Vitality Stardust LV4", new[]
                {
                    new Requirement("Vitality Stardust LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Spirit Stardust LV4", new[]
                {
                    new Requirement("Spirit Stardust LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Dexterity Stardust LV4", new[]
                {
                    new Requirement("Dexterity Stardust LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of HP LV4", new[]
                {
                    new Requirement("Stardust of HP LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of MP LV4", new[]
                {
                    new Requirement("Stardust of MP LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Physical Defense LV4", new[]
                {
                    new Requirement("Stardust of Physical Defense LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Magic Defense LV4", new[]
                {
                    new Requirement("Stardust of Magic Defense LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Accuracy LV4", new[]
                {
                    new Requirement("Stardust of Accuracy LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Evasion LV4", new[]
                {
                    new Requirement("Stardust of Evasion LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Physical Attack LV4", new[]
                {
                    new Requirement("Stardust of Physical Attack LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Magic Attack LV4", new[]
                {
                    new Requirement("Stardust of Magic Attack LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Fire Resistance LV4", new[]
                {
                    new Requirement("Stardust of Fire Resistance LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Ice Resistance LV4", new[]
                {
                    new Requirement("Stardust of Ice Resistance LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Dark Resistance LV4", new[]
                {
                    new Requirement("Stardust of Dark Resistance LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Light Resistance LV4", new[]
                {
                    new Requirement("Stardust of Light Resistance LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Super Stardust of HP LV4", new[]
                {
                    new Requirement("Super Stardust of HP LV3", 3),
                    new Requirement("Crystal Sphere", 5),
                    new Requirement("Sacred Particles", 20)
                }),
                new Stardust("Stardust of Ice Attack LV4", new[]
                {
                    new Requirement("Stardust of Ice Attack LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Dark Attack LV4", new[]
                {
                    new Requirement("Stardust of Dark Attack LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Fire Attack LV4", new[]
                {
                    new Requirement("Stardust of Fire Attack LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Stardust of Light Attack LV4", new[]
                {
                    new Requirement("Stardust of Light Attack LV3", 3),
                    new Requirement("Aquamarine", 10, true),
                    new Requirement("Celesoul Crystal", 2)
                }),
                new Stardust("Divine Physical Attack Stardust LV4", new[]
                {
                    new Requirement("Super Physical Attack Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Magic Attack Stardust LV4", new[]
                {
                    new Requirement("Super Magic Attack Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Accuracy Stardust LV4", new[]
                {
                    new Requirement("Super Accuracy Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Evasion Stardust LV4", new[]
                {
                    new Requirement("Super Evasion Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Stardust of HP LV4", new[]
                {
                    new Requirement("Super Stardust of HP LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Stardust of MP LV4", new[]
                {
                    new Requirement("Super Stardust of MP LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Stardust of Physical Defense LV4", new[]
                {
                    new Requirement("Super Stardust of Physical Defense LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Stardust of Magical Defense LV4", new[]
                {
                    new Requirement("Super Stardust of Magical Defense LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Strength Stardust LV4", new[]
                {
                    new Requirement("Super Strength Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Intellect Stardust LV4", new[]
                {
                    new Requirement("Super Intellect Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Vitality Stardust LV4", new[]
                {
                    new Requirement("Super Vitality Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Spirit Stardust LV4", new[]
                {
                    new Requirement("Super Spirit Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Dexterity Stardust LV4", new[]
                {
                    new Requirement("Super Dexterity Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                }),
                new Stardust("Divine Lucky Stardust LV4", new[]
                {
                    new Requirement("Super Lucky Stardust LV4", 1),
                    new Requirement("God's Crystalized Body", 1),
                    new Requirement("God's Tears", 1)
                })
            };
        }

        public List<Stardust> GetStardusts()
        {
            return _stardusts;
        }

        private Stardust GetStardust(string name)
        {
            return _stardusts.First(s => s.Name.ToLower().Trim().Equals(name.ToLower().Trim()));
        }

        public List<Requirement> GetRequirements(string stardustName)
        {
            var allRequirements = new List<Requirement>();
            var stardust = GetStardust(stardustName);

            foreach (var requirement in stardust.Requirements)
            {
                if (requirement.Name.ToLower().Contains("stardust") && !requirement.Name.ToLower().Equals("sealed stardust"))
                {
                    allRequirements.AddRange(
                        GetRequirements(requirement.Name));
                }

                if (!allRequirements.Any(x => x.Name.ToLower().Equals(requirement.Name.ToLower())))
                {
                    allRequirements.Add(requirement);
                }
                else
                {
                    var existingRequirement =
                        allRequirements.First(r => r.Name.ToLower().Equals(requirement.Name.ToLower()));
                    existingRequirement.Amount += requirement.Amount;
                }
            }

            return allRequirements;
        }
    }
}