# NodaTime.Global

Global instance for NodaTime `IClock` to help with testing.

Defaults to `SystemClock.Instance`.

## Important

Using a global mutable singleton is considered an anti pattern and bad practice. You should instead be injecting an `IClock` instance whenever possible.

# Attribution

- Icon made by [srip](https://www.flaticon.com/authors/srip) from [www.flaticon.com](https://www.flaticon.com/)
