# Define all functions required to run program at first
def splash():
    print("------------")
    print("MultiUnit v1")
    print("--------------------------------")
    print("Copyright Matthew Yang 2024-2025")
    print("--------------------------------")

def mainmenu():
    # Print out the options
    print("What type of unit do you want to convert?")
    print("0. Quit")
    option = int(input("Enter a number:"))
    
    # Conditional loops to parse user feedback
    if option == 0:
        print("Exiting...")
        exit()

def cfmlfm(x):
    # Convert CFM to LFM if the input is 1
    if x == 1:
        cfm = input("Enter your CFM here: ")
        cfmint = int(cfm)
        area = input("Enter your area (ft^2): ")
        areaint = int(area)
        lfm = cfmint/areaint
        print("LFM = " + str(lfm))
    
    # COnvert LFM to CFM if the input is 2
    elif x == 2:
        lfm = input("Enter your LFM here: ")
        lfmint = int(lfm)
        area = input("Enter your area here:")
        areaint = int(area)
        cfm = lfmint * areaint
        print("CFM = " + str(cfm))

# Display the welcome splash screen
splash()

# Forever loop that loops until user exits with the "quit" option
while True:
    mainmenu()