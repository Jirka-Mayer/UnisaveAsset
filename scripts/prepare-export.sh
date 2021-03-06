# Prepare Export
# --------------
#
# This script prepares the repository for export to Unity Asset Store.
# It does that by making a copy of this directory and preparing it.

# copy the Asset directory to AssetForExport and go into the copy
cd ../../
rm -rf ./AssetForExport
cp -r ./Asset ./AssetForExport
cd ./AssetForExport

# remove unnecessary unisave files
rm ./Assets/Unisave/Resources/UnisavePreferencesFile.asset*

# remove unisave fixture
rm -r ./Assets/UnisaveFixture*

