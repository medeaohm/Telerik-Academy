##XML##

Extensible Markup Language (XML) is a markup language that defines a set of rules for encoding documents in a format which is both human-readable and machine-readable. 
The design goals of XML emphasize simplicity, generality and usability across the Internet. It is a textual data format with strong support via Unicode for different human languages. Although the design of XML focuses on documents, it is widely used for the representation of arbitrary data structures such as those used in web services.
Several schema systems exist to aid in the definition of XML-based languages, while many application programming interfaces (APIs) have been developed to aid the processing of XML data.


**Applications of XML**
As of 2009, hundreds of document formats using XML syntax have been developed. XML-based formats have become the default for many office-productivity tools, including Microsoft Office (Office Open XML), OpenOffice.org and LibreOffice (OpenDocument), and Apple's iWork. XML has also been employed as the base language for communication protocols. Applications for the Microsoft .NET Framework use XML files for configuration. Apple has an implementation of a registry based on XML.


**Key terminology**
The below is not an exhaustive list of all the constructs that appear in XML; it provides an introduction to the key constructs most often encountered in day-to-day use.

* **(Unicode) character**
By definition, an XML document is a string of characters. Almost every legal Unicode character may appear in an XML document.

* **Processor and application**
The processor analyzes the markup and passes structured information to an application. The specification places requirements on what an XML processor must do and not do, but the application is outside its scope. The processor (as the specification calls it) is often referred to colloquially as an XML parser.

* **Markup and content**
The characters making up an XML document are divided into markup and content, which may be distinguished by the application of simple syntactic rules. Generally, strings that constitute markup either begin with the character < and end with a >, or they begin with the character & and end with a ;. Strings of characters that are not markup are content. In addition, whitespace before and after the outermost element is classified as markup.

* **Tag**
A markup construct that begins with < and ends with >. Tags come in three flavors:
	+ ***start-tags***; for example: < section>
	+ ***end-tags***; for example: < /section>
	+ ***empty-element tags***; for example: < line-break />

* **Element**
A logical document component which either begins with a start-tag and ends with a matching end-tag or consists only of an empty-element tag. The characters between the start- and end-tags, if any, are the element's content, and may contain markup, including other elements, which are called child elements. An example of an element is 
	< Greeting>
		 Hello, world.
	< / Greeting> 
Another is < line-break />.

* **Attribute**
A markup construct consisting of a name/value pair that exists within a start-tag or empty-element tag.  An XML attribute can only have a single value and each attribute can appear at most once on each element. In the common situation where a list of multiple values is desired, this must be done by encoding the list into a well-formed XML attribute with some format beyond what XML defines itself. Usually this is either a comma or semi-colon delimited list or, if the individual values are known not to contain spaces, a space-delimited list can be used.

* **XML declaration**
XML documents may begin by declaring some information about themselves, as in the following example:
< ? xml version="1.0" encoding="UTF-8"?>