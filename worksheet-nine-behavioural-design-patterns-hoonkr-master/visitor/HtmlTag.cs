using System.Collections.Generic;

namespace visitor
{
    public interface HtmlTag
    {
        public string TagName { get; set; }

        public string StartTag { get; set; }

        public string EndTag { get; set; }

        public string TagBody { get; set; }

        public void AddChildTag(HtmlTag htmlTag);

        public void RemoveChildTag(HtmlTag htmlTag);

        public List<HtmlTag> GetChildren();

        public void GenerateHtml();


        public void Accept(IVisitor style);

    }
}