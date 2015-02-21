﻿using System;
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

            TraitGroup Abilities = new TraitGroup(
                Name: "Abilities",
                ColumnLabels: new List<string>(),
                Children: new List<Trait>(),
                ChildGroups: new List<TraitGroup>
                {
                    new TraitGroup(
                        Name: "Talents",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                        new NameTextRating(Name: "Alertness", Text: string.Empty, Rating: 2),
                        new NameTextRating(Name: "Athletics", Text: "Climbing", Rating: 5),
                        new NameTextRating(Name: "Brawl", Text: string.Empty, Rating: 3),
                        new NameTextRating(Name: "Dodge", Text: string.Empty, Rating: 0),
                        new NameTextRating(Name: "Empathy", Text: string.Empty, Rating: 0),
                        new NameTextRating(Name: "Expression", Text: string.Empty, Rating: 0),
                        new NameTextRating(Name: "Intimidation", Text: string.Empty, Rating: 1),
                        new NameTextRating(Name: "Primal-Urge", Text: string.Empty, Rating: 0),
                        new NameTextRating(Name: "Streetwise", Text: string.Empty, Rating: 1),
                        new NameTextRating(Name: "Subterfuge", Text: string.Empty, Rating: 0),
                        }
                    ),
                    new TraitGroup(
                        Name: "Skills",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NameTextRating(Name: "Animal Ken ", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Drive ", Text: string.Empty, Rating: 1),
                            new NameTextRating(Name: "Etiquette", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Firearms ", Text: string.Empty, Rating: 1),
                            new NameTextRating(Name: "Melee ", Text: string.Empty, Rating: 1),
                            new NameTextRating(Name: "Leadership", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Performance ", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Repair ", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Stealth", Text: string.Empty, Rating: 1),
                            new NameTextRating(Name: "Survival  ", Text: string.Empty, Rating: 0),
                        }
                    ),
                    new TraitGroup(
                        Name: "Knowledges",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), Children: new List<Trait>{
                            new NameTextRating(Name: "Computer ", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Enigmas ", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Investigation", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Law ", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Linguistics ", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Medicine", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Occult ", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Politics ", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Rituals", Text: string.Empty, Rating: 0),
                            new NameTextRating(Name: "Science ", Text: string.Empty, Rating: 0),
                        }
                    )
                });
            Char.TraitGroups.Add(Abilities);

            TraitGroup BackgroundsGifts = new TraitGroup(
                Name: "",
                ColumnLabels: new List<string>(),
                SpanColumns: 3,
                Children: new List<Trait>(),
                ChildGroups: new List<TraitGroup>
                {
                    new TraitGroup(
                        Name: "Backgrounds",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), SpanColumns:1, Children: new List<Trait>{
                        new TextRating(),
                        new TextRating(),
                        new TextRating(),
                        new TextRating(),
                        new TextRating(),
                        }),
                        
                    new TraitGroup(
                        Name: "Gifts",
                        ChildGroups: new List<TraitGroup>(), ColumnLabels: new List<string>(), SpanColumns:2, Children: new List<Trait>{
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        new TextTrait(),
                        }
                    ),
                }
                );
            Char.TraitGroups.Add(BackgroundsGifts);
            return Char;
        }
    }
}
