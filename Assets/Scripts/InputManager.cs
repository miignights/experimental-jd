using UnityEngine;

public static class InputManager
{
    public static InputSource source = InputSource.Local;
    public static InputSource controller = InputSource.Local;
    public static NetworkInput input = NetworkInput.None;

    public static bool Undo()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
        {
            source = InputSource.Local;
            return true;
        }
        if (input == NetworkInput.Undo)
        {
            input = NetworkInput.None;
            return true;
        }
        return false;
    }

    public static bool Select()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            source = InputSource.Local;
            return true;
        }
        if (input == NetworkInput.Select)
        {
            input = NetworkInput.None;
            return true;
        }
        return false;
    }

    public static bool Up()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            source = InputSource.Local;
            return true;
        }
        if (input == NetworkInput.Up)
        {
            input = NetworkInput.None;
            return true;
        }
        return false;
    }

    public static bool Down()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            source = InputSource.Local;
            return true;
        }
        if (input == NetworkInput.Down)
        {
            input = NetworkInput.None;
            return true;
        }
        return false;
    }

    public static bool Left()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            source = InputSource.Local;
            return true;
        }
        if (input == NetworkInput.Left)
        {
            input = NetworkInput.None;
            return true;
        }
        return false;
    }

    public static bool Right()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            source = InputSource.Local;
            return true;
        }
        if (input == NetworkInput.Right)
        {
            input = NetworkInput.None;
            return true;
        }
        return false;
    }
}

public enum NetworkInput
{
    None,
    Undo,
    Select,
    Up,
    Down,
    Left,
    Right
}

public enum InputSource
{
    Local,
    Dancer01,
    Dancer02,
    Dancer03,
    Dancer04
}
