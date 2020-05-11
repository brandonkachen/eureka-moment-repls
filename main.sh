
# Compile: must do individually because each has its own main fn
# -nologo -> don't output compiler version info
# -nowarn -> don't output warning
# -errorreport -> what to do when compiler encounters an error
for each in ./*.cs ; do csc -nologo -nowarn:219 -errorreport:send $each ; done

# Run each individually
for each in ./*.exe ; do mono $each ; done

# Clean up
rm *.exe