# Define all functions required to run program at first
def splash():
    print("------------")
    print("MultiUnit v1")
    print("--------------------------------")
    print("Copyright Matthew Yang 2024-2025")
    print("--------------------------------")

def mainmenu():
    print("What type of unit do you want to convert?")

def cfmlfm(x):
    if x == 1:
        cfm = input("Enter your CFM here: ")
        cfmint = int(cfm)
        area = input("Enter your area (ft^2): ")
        areaint = int(area)
        lfm = cfmint/areaint
        print("LFM = " + str(lfm))
    
    elif x == 2:
        lfm = input("Enter your LFM here: ")
        lfmint = int(lfm)
        area = input("Enter your area here:")
        areaint = int(area)
        cfm = lfmint * areaint
        print("CFM = " + str(cfm))

# Display the welcome splash screen
splash()
