using System;

class Information : IComparable<Information>
{
    private string name;
    private string category;
    private string structure;
    private string definition;

    public Information(string name, string category, string structure, string definition)
    {
        this.name = name;
        this.category = category;
        this.structure = structure;
        this.definition = definition;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    public string Structure
    {
        get { return structure; }
        set { structure = value; }
    }

    public string Definition
    {
        get { return definition; }
        set { definition = value; }
    }

    public int CompareTo(Information other)
    {
        return this.Name.CompareTo(other.Name);
    }
}
 