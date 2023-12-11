namespace Stirnreihen.Logic
{
    public class LineOfPeople
    {
        public Node? First { get; set; }

        public void AddToFront(Person person)
        {
            // neue eine node variable wird erstellt
            Node nodePerson = new Node();
            // der Person in node wird eine person zugewiesen
            nodePerson.Person = person;
            // die jetzige first nodePerson wird wird zur nächsten
            nodePerson.Next = First;
            // die erstellte nodePerson wird first
            First = nodePerson;
        }
        public void Clear()
        {
            // Wenn first gelöscht wird löscht der Garbage Collector den rest 
            First = null;
        }
        /*
        public void AddSorted(Person person)
        {
            if (person.Height < First.Person.Height)
            {
                First.Person = person;
                First.Next = First;
            } 
        }
        */
    }
}
