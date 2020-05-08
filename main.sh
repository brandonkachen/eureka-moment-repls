
# Compile: must do individually because each has its own main fn
# -nologo -> don't output compiler version info
# -errorreport -> what to do when compiler encounters an error
for each in ./*.cs ; do csc -nologo -errorreport:send $each ; done

# Run each individually
for each in ./*.exe ; do mono $each ; done

# Clean up
rm *.exe