namespace Graph;

public class GraphBase
{
    public GraphBase() { }
    
    private List<Vertex> _vertices = new();
    private List<Edge> _edges = new();
    public int VertexCount => _vertices.Count;
    public int EdgeCount => _edges.Count;

    public int[,] GetMatrix()
    {
        var martix = new int[_vertices.Count, _vertices.Count];
        foreach (var edge in _edges)
        {
            var row = edge.From.Number - 1;
            var column = edge.To.Number - 1;

            martix[row, column] = edge.Weight;
        }

        return martix;
    }

    public void AddVertex(Vertex vertex)
    {
        _vertices.Add(vertex);
    }

    public void AddEdge(Vertex from, Vertex to)
    {
        var edge = new Edge(from, to);
        _edges.Add(edge);
    }

    public List<Vertex> GetVertexList(Vertex vertex)
    {
        var result = new List<Vertex>();

        foreach (var edge in _edges)
        {
            if(edge.From == vertex)
                result.Add(edge.To);
        }

        return result;
    }
}