# DesktopNotifier

A very simple command line program to send Windows Desktop Notifications.

## Usage

### Example

``` batchfile
> DesktopNotifier.exe -t Title -m "Hello, Notifications!"
```

### Options

```
  -m, --message     Required. (Default: Hello, World) The message to display.

  -t, --title       Required. (Default: Terminal) The title text to display.

  -i, --icon        The path to a .ico file to display.

  -s, --showTime    (Default: 10000) The length of time to show notification
                    for in milliseconds.
```

## License

Copyright 2016 Geoff Shannon
Released under the MIT License.
