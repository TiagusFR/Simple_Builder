Simple Builder Pattern based on the following scenario:
"Build a component that renders webpages. A page might consist of just a single paragraph"

-HtmlElement: Models a single HTML tag with a name and can also contain either text or a number of children, wich are themselves HtmlElements.
-HtmlBuilder: Outsource the piecewise construction of an object into a separate class.

Use of Fluent Builder: Returning a reference to the Builder itself, the Builder calls can now be chained.
