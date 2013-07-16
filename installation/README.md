This is a repo of the intermediate files from running User massive quine relay at:

https://github.com/mame/quine-relay

## Notes on fork ##

I originally started a repo to show the intermediate files but it ended up being a big project in itself so I decided to do this as a fork. This directory includes additional help on setting up the Quine relay to work.

## What else you (may) need to do to get this to work##

I ran this on Linux Mint 12.  Here are the steps beyond those shown in the link above that I had to follow to get this working.  They are reflected in my `../intermediate/generate_quine_relay.sh` file, which comments out the lines that didn't work for me in User:Mame's README, and adds the lines I ended up using to get it to work.

### Capitalization issues ###

I ended up having to change the whitespace.rb and gnatmake lines in the generation code from 

    ruby whitespace.rb QR.ws > QR.adb
    ...
    gnatmake QR.adb && ./QR > QR.a68

to

    ruby whitespace.rb QR.ws > qr.adb
    ...
    gnatmake qr.adb && ./qr > QR.a68

in order to get it to work.

### Ruby ###

I was fortunate enough to already have 1.9.3 installed and set to run from the `ruby` command.  Good luck.

### Go language ###

You will also need to have the "go" command set up after installing golang (`apt-get install golang` is not enough).  Follow the instructions here:

http://golang.org/doc/install#environment

### Intercal ###

This one's tricky.  On Linux Mint, `apt-get install` didn't work for me.  Per the instructions here:

http://catb.org/esr/intercal/ick.htm#toc_Installation

I ended up downloading it from here (which I found from searching the newsgroup ... oy):

http://c.intercal.org.uk/download/#n5

Then go to the directory you downloaded it to and run these commands:

    tar xvf intercal-0.29.pax.gz  # or whatever the version is
    cd intercal-0.29
    mkdir build
    cd build
    ../configure
    make
    sudo make install

That should leave you with `ick` on your path and ready to use for that part of it.

### Node.js ###

After installing node.js via `apt-get install`, I was set up to run it with the `node` command rather than `nodejs`.
