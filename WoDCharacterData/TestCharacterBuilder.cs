using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Games.RPG.WoDCharacterData
{
    public class TestCharacterBuilder
    {
        public static WoDCharacter TestCharacter()
        {
            WoDCharacter Char = new WoDCharacter();
            Char.Name = "Werewolf: The Apocalypse";
            Char.Graphic = @"D:\Documents\Visual Studio 2013\Projects\WoDSheet\img\Werewolf_The_Apocalypse.png";

            SetupCharacterConcept(Char);
            SetupAttributes(Char);
            SetupAbilities(Char);
            SetupAdvantages(Char);
            SetupWerewolfTraits(Char);

            return Char;
        }
        private static void SetupWerewolfTraits(WoDCharacter Char) {
            TraitGroup Abilities = new TraitGroup(
                Name: "Traits",
                ColumnLabels: new List<string>(),
                Children: new List<Trait>(),
                ChildGroups: new List<TraitGroup>
                {
                    new TraitGroup( // Reknown and Rank
                        Name: "",
                        Orientation: "TopToBottom", ChildGroups: new List<TraitGroup>{
                            new TraitGroup(
                                Name: "Reknown",
                                ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                                    new NamedRatingWithTempValue(Name: "Glory", Rating: 0, Temporary: 0, Minimum: 0, Maximum: 10 ),
                                    new NamedRatingWithTempValue(Name: "Honor", Rating: 0, Temporary: 0, Minimum: 0, Maximum: 10 ),
                                    new NamedRatingWithTempValue(Name: "Wisdom", Rating: 0, Temporary: 0, Minimum: 0, Maximum: 10 ),
                                }
                            ),
                            new TraitGroup(
                                Name: "Rank",
                                ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                                    new TextTrait(),
                                }
                            ),
                        }, ColumnLabels: new List<string>(), Children: new List<Trait>()
                    ),
                    new TraitGroup( // Rage Gnosis Willpower
                        Name: "",
                        Orientation: "TopToBottom", ChildGroups: new List<TraitGroup>{}, ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NamedRatingWithTempValue(Name: "Rage", Rating: 0, Temporary: 0, Minimum: 1, Maximum: 10 ),
                            new NamedRatingWithTempValue(Name: "Gnosis", Rating: 0, Temporary: 0, Minimum: 1, Maximum: 10 ),
                            new NamedRatingWithTempValue(Name: "Willpower", Rating: 0, Temporary: 0, Minimum: 1, Maximum: 10 ),
                        }
                    ),
                    new TraitGroup(
                        Name: "", // Health and XP
                        Orientation: "TopToBottom", ChildGroups: new List<TraitGroup>{
                            new TraitGroup(
                                Name: "Health",
                                ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                                    new WoundRating("Bruised",0),
                                    new WoundRating("Hurt",-1),
                                    new WoundRating("Injured",-1),
                                    new WoundRating("Wounded",-2),
                                    new WoundRating("Mauled",-2),
                                    new WoundRating("Crippled",-5),
                                    new WoundRating("Incapacitated",0),
                                }
                            ),
                            new TraitGroup(
                                Name: "Experience",
                                ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                                    new TextTrait(),
                                }
                            ),
                        }, ColumnLabels: new List<string>(), Children: new List<Trait>()
                    )
                });
            Char.TraitGroups.Add(Abilities);
        }

        private static void SetupAdvantages(WoDCharacter Char) {
            TraitGroup Advantages = new TraitGroup(
                Name: "Advantages",
                ColumnLabels: new List<string>(),
                SpanColumns: 3,
                Children: new List<Trait>(),
                ChildGroups: new List<TraitGroup>
                {
                    new TraitGroup(
                        Name: "Backgrounds",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), SpanColumns:1, Children: new List<Trait>{
                        new UnnamedTextRating(),
                        new UnnamedTextRating(),
                        new UnnamedTextRating(),
                        new UnnamedTextRating(),
                        new UnnamedTextRating(),
                        }),
                        
                    new TraitGroup(
                        Name: "Gifts",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), SpanColumns:1, Children: new List<Trait>{
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        }
                    ),
                        
                    new TraitGroup(
                        Name: "Gifts",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), SpanColumns:1, Children: new List<Trait>{
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        }
                    ),
                }
                );
            Char.TraitGroups.Add(Advantages);
        }

        private static void SetupAbilities(WoDCharacter Char) {
            TraitGroup Abilities = new TraitGroup(
                Name: "Abilities",
                ColumnLabels: new List<string>(),
                Children: new List<Trait>(),
                ChildGroups: new List<TraitGroup>
                {
                    new TraitGroup(
                        Name: "Talents",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                        new NameTextRating(Name: "Alertness", Text: string.Empty, Rating: 2, Minimum: 0, Maximum: 5),
                        new NameTextRating(Name: "Athletics", Text: "Climbing", Rating: 5, Minimum: 0, Maximum: 5),
                        new NameTextRating(Name: "Brawl", Text: string.Empty, Rating: 3, Minimum: 0, Maximum: 5),
                        new NameTextRating(Name: "Dodge", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                        new NameTextRating(Name: "Empathy", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                        new NameTextRating(Name: "Expression", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                        new NameTextRating(Name: "Intimidation", Text: string.Empty, Rating: 1, Minimum: 0, Maximum: 5),
                        new NameTextRating(Name: "Primal-Urge", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                        new NameTextRating(Name: "Streetwise", Text: string.Empty, Rating: 1, Minimum: 0, Maximum: 5),
                        new NameTextRating(Name: "Subterfuge", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                        }
                    ),
                    new TraitGroup(
                        Name: "Skills",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NameTextRating(Name: "Animal Ken ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Drive ", Text: string.Empty, Rating: 1, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Etiquette", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Firearms ", Text: string.Empty, Rating: 1, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Melee ", Text: string.Empty, Rating: 1, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Leadership", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Performance ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Repair ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Stealth", Text: string.Empty, Rating: 1, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Survival  ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                        }
                    ),
                    new TraitGroup(
                        Name: "Knowledges",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NameTextRating(Name: "Computer ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Enigmas ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Investigation", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Law ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Linguistics ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Medicine", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Occult ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Politics ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Rituals", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                            new NameTextRating(Name: "Science ", Text: string.Empty, Rating: 0, Minimum: 0, Maximum: 5),
                        }
                    )
                });
            Char.TraitGroups.Add(Abilities);
        }

        private static void SetupAttributes(WoDCharacter Char) {
            TraitGroup Attributes = new TraitGroup(
                Name: "Attributes",
                ColumnLabels: new List<string>(),
                Children: new List<Trait>(),
                ChildGroups: new List<TraitGroup>
                {
                    new TraitGroup(
                        Name: "Physical",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NameTextRating(Name: "Strength", Text: string.Empty, Rating: 4),
                            new NameTextRating(Name: "Dexterity", Text: string.Empty, Rating: 2),
                            new NameTextRating(Name: "Stamina", Text: string.Empty, Rating: 3)
                        }
                    ),
                    new TraitGroup(
                        Name: "Social",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NameTextRating(Name: "Charisma", Text: string.Empty, Rating: 3),
                            new NameTextRating(Name: "Manipulation", Text: string.Empty, Rating: 2),
                            new NameTextRating(Name: "Appearance", Text: string.Empty, Rating: 1)
                        }
                    ),
                    new TraitGroup(
                        Name: "Mental",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NameTextRating(Name: "Perception", Text: string.Empty, Rating: 4),
                            new NameTextRating(Name: "Intelligence", Text: string.Empty, Rating: 1),
                            new NameTextRating(Name: "Wits", Text: string.Empty, Rating: 3)
                        }
                    )
                }
            );
            Char.TraitGroups.Add(Attributes);
        }

        private static void SetupCharacterConcept(WoDCharacter Char) {
            TraitGroup Background = new TraitGroup(Name: string.Empty, ColumnLabels: new List<string>(), Children: new List<Trait>(),
                ChildGroups: new List<TraitGroup>
                {
                    new TraitGroup(
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NamedText(Name: "Name", Text: "Test Character"),
                            new NamedText(Name: "Player", Text: "Emily"),
                            new NamedText(Name: "Chronicle", Text: "Test Chronicle"),
                        }
                    ),
                    new TraitGroup(
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NamedText(Name: "Breed", Text: "Homid"),
                            new NamedText(Name: "Auspice", Text: "Ahroun"),
                            new NamedText(Name: "Tribe", Text: "Get of Fenris"),
                        }
                    ),
                    new TraitGroup(
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NamedText(Name: "Pack Name", Text: "Some Guys"),
                            new NamedText(Name: "Pack Totem", Text: "Volcano"),
                            new NamedText(Name: "Concept", Text: "Unstable!")
                        }
                    )
                }
            );

            Char.TraitGroups.Add(Background);
        }
    }
}
