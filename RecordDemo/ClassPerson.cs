namespace RecordDemo;

public class ClassPerson : IEquatable<ClassPerson>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public bool Equals(ClassPerson? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return FirstName == other.FirstName && LastName == other.LastName;
    }

    public override bool Equals(object? obj)
    {
        Console.WriteLine(obj);
        
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ClassPerson)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName);
    }

    public override string ToString()
    {
        return $"{nameof(ClassPerson)} [ {nameof(FirstName)} = {FirstName}, {nameof(LastName)} = {LastName} ]";
    }
}