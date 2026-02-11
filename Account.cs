namespace knightmoves;

public class Account {
    public static int OriginalTaxRate = 10;
    public static int[] CurrentLedger = {10, 20, 30, 40, 50};

    public int NewTaxRate = OriginalTaxRate;
    public int[] CopyLedger = CurrentLedger;

public int UpdateLedger (int correction) 
{
    correction = 15
    CurrentLedger[0] = correction;
}

public int AdjustTaxRate (int taxRate)
{
    taxRate = 15;
    NewTaxRate = taxRate;

    return NewTaxRate;
}
}

