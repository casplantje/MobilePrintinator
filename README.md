# MobilePrintinator

.net MAUI compatible library for using bluetooth ESC/POS printers.

## General

### Features

This library is not feature-complete yet, but here's a list of what it can do:

- Works on Android
- Generates common ESC/POS codes for driving thermal printers
- Can drive PT-2xx model bluetooth printers(at the moment only PT-230 is tested)
- Can print large font, bold font, italic, underline(support for each depends on printer)
- Can print images

### Work in progress

Parts are added, but are unfinished or untested at the moment

- Barcodes
- QR-codes

### Wishlist

No promises on whether or when these features will be added.

- Support for more common ESC/POS features
- "Cat-printer" support
- iOS support
- More unified and foolproof configuration method(keeping complex printer-specific parameters away from the user unless they really want to touch them)
- See if android phones could work with an USB-connected ESC/POS printer

## Architecture

### Projects

The solution currently consists of 3 different projects:

- MobilePrintinator
- MobilePrintinatorMaui
- MobilePrintinator-Tests

`MobilePrintinator` is the class library containing all platform-independent parts. By keeping those all there, it's easier to run tests on them by `MobilePrintinator-Tests`, which is an NUnit project(running NUnit tests for MAUI-specific code should be possible, but I couldn't find an easily maintainable testrunner for the latest MAUI version).
`MobilePrintinatorMaui` is a MAUI class library with all the MAUI- and platform-specific parts.