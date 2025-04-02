
using Lab1Task2Demo.Models;

Membership membership = new Membership
{
    MembershipNumber = "123",
    Name = "Monthly Workout #5665"
};

Member member1 = new Member
{
    Name = "John Doe",
    DateJoined = new DateTime(2025,1,1),
    Membership = membership
};

Member member2 = new Member
{
    Name = "Joan Doe",
    DateJoined = new DateTime(2024, 10, 10),
    Membership = membership
};

Trainer trainer = new Trainer
{
    Name = "Jane Trainer",
    HourlyRate = 50
};

var eqs = new Equipment[]
{
    new Equipment { Name = "Treadmill" },
    new Equipment { Name = "Elliptical" },
    new Equipment { Name = "Bench Press" }
};

Workout workout = new GroupTraining
{
    Date = new DateTime(2025, 1, 1),
    Trainer = trainer,
    Equipment = eqs,
    Title = "Fun monday training",
    Participants = new Member[] { member1, member2 }
};

Schedule schedule = new Schedule();
schedule.AddWorkout(workout);

foreach(var w in schedule.Workouts)
{
    Console.WriteLine(w);
}

member1.Membership.AddPayment(new Payment
{
    Amount = 99.99,
    PaymentType = "Credit Card"
});

member1.Membership.AddPayment(new Payment
{
    Amount = 123.55,
    PaymentType = "Google Pay"
});

foreach(var p in member1.Membership.Payments)
{
    Console.WriteLine(p);
}