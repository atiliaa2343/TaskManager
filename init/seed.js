// Create a users collection with one test user
db.users.insertOne({
  username: "testuser",
  email: "testuser@example.com",
  password: "hashedpassword123", // normally you'd hash this!
  role: "tester"
});

// Create a tasks collection with sample tasks
db.tasks.insertMany([
  { title: "Set up Docker on AWS", status: "in-progress", assignedTo: "testuser" },
  { title: "Write first QA test case", status: "todo", assignedTo: "testuser" },
  { title: "Push code to GitHub", status: "done", assignedTo: "testuser" }
]);
