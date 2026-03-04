struct Health
{
    public int value;

    public Health(int v)
    {
        value = v;
    }

    // public static explicit operator int(Health h)
    public static implicit operator int(Health h)
    {
        return h.value;
    }

    // public static explicit operator Health(int v)
    public static implicit operator Health(int v)
    {
        return new Health(v);
    }
}
