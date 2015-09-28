##XML Namespaces##

**Why do we need namespaces?**
There are really two fundamental needs for namespaces:

 1. To disambiguate between two elements that happen to share the same name
	 + In (x)html there is a table element. There is also an element of the same name in XSL-FO
	 + a, title and style are all elements in both (x)html and SVG.

 2. To group elements relating to a common idea together
	+ In (x)html, the table, style and a elements are governed by specific rules about what is required, and what may and may not be included. The definitions required by these rules should all be included in the same place.
	+ So, for example, my own XML-based data may have validating rules, and I will want to:
		+ define those rules in the same place, and
		+ differentiate these particular rules from any other rule-set that I (or someone else) define


**What is a Namespace?**
A namespace is a unique URI (Uniform Resource Locator)
The advantage of this format is that anyone who transmits XML can be assumed to have access to a domain name (the bit after the http://, but before the next /). It’s bad form to piggy-back on someone else’s domain (especially if they don’t know you’re doing it!).
In an XML document, the URI is associated with a prefix, and this prefix is used with each element to indicate to which namespace the element belongs.


**How do I use a Namespace?**
To use a namespace, you first associate the URI with a namespace:

    <foo:tag xmlns:foo="http://me.com/namespaces/foofoo">

This defines foo as the prefix for the namespace for that element tag. The attribute prefixed with xmlns works like a command to say "link the following letters to a URI". As no well-formed document can contain two identical attributes, the part that appears after the colon stops the same prefix being defined twice simultaneously.