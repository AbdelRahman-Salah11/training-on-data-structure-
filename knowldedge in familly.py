import time    #here it's used to pause the run of the next code as soon it's used

Family=set(["mother","father","brother"])

person = str(input("how is the person!? "))

print("does {} belong to the family".format(person))

time.sleep(2) #the applied code for pause it

if person.lower() in Family:
    
    print(person + " is one of the family")

else:
   
    print(person + " is a forgien from family")