using ExercicioTree;

Tree tree= new Tree();

tree.Root = new Node(){
    Data = new Person(){Name = "Marcin Jamro",Role = "CEO"}
};

tree.Root.Children = new List<Node>(){
    new Node(){Data = new Person (){Name = "John Smith", Role="Head of Develpment"}, Parent = tree.Root},
    new Node(){Data = new Person (){Name = "Mary Fox", Role="Head of Research"}, Parent = tree.Root},
    new Node(){Data = new Person (){Name = "Lily Smith", Role="Head of Sales"}, Parent = tree.Root}

};

tree.Root.Children[0].Children = new List<Node>(){
    new Node(){Data = new Person (){Name = "Chris Morris", Role="Senior Develpment"}, Parent = tree.Root.Children[0]}
};

tree.Root.Children[0].Children[0].Children = new List<Node>(){
    new Node(){Data = new Person (){Name = "Chris Morris", Role="Senior Develpment"}, Parent = tree.Root.Children[0].Children[0]}
};