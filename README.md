# WorldOfDarknessCharacterSheet
C# program that aims to be useful for any kind of World Of Darkness character 
(or at least any WoD-like character using sheet elements you can find on an official WoD sheet)

The basic concept is that a WoD-like character sheet is the data storage model - each collection 
of traits maps directly to a trait-collection object (which in turn may contain zero-or-many collections of traits).
So for example the Attributes trait-group contains 3 trait groups: Physical, Social, and Mental.

Eventually you tunnel down to a traitgroup that contains nothing but an optional label for itself (eg Physical) 
and some traits (eg: Strength, Dexterity, Stamina). I currently support traits with a label and a text value 
(like Chronicle or Player Name), a label, dot rating, and optional text specialty (like Attributes and Backgrounds),
a simple text item (like a Gift), or a wound level (a name, an optional penalty column, and a 4-state checkboxy thing).

I will be expanding to handle dot-rating and temporary score traits (like Rage or Blood), traits that are a label
and some checkboxes (like that circular thing in Mage, although mine probably won't be circular), and eventually I
want to handle making things like Backgrounds into combo-boxes so you can pick from a list instead of entering text.

Everything gets saved as XML. It can load too! It can't print or export to PDF or other formats yet, but I plan on 
doing these too. I expect to support at least exporting out a plain text document, and I'll try to tackle one of 
printing or PDF generation; this is new territory so woohoo.
