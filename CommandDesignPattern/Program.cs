// See https://aka.ms/new-console-template for more information

using CommandDesignPattern;

Fan fan1 = new Fan("FAN 1");
Fan fan2 = new Fan("FAN 2");
Fan fan3 = new Fan("FAN 3");
Light l1 = new Light("LIGHT 1");
Light l2 = new Light("LIGHT 2");


Stack<ICommand> st = new Stack<ICommand>();
ICommand command = new LightOnCommand(l1);
command.Execute();
st.Push(command);

command = new LightOffCommand(l1);
command.Execute();
st.Push(command);
command = new LightOnCommand(l2);
command.Execute();
st.Push(command);
command = new FanOnCommand(fan1);
command.Execute();
st.Push(command);
command = new FanOnCommand(fan2);
command.Execute();
st.Push(command);
command = new FanOffCommand(fan1);
command.Execute();
st.Push(command);

//Undo - stack for undo
ICommand undoCommand = st.Pop();
undoCommand.Undo();
undoCommand = st.Pop();
undoCommand.Undo();
undoCommand = st.Pop();
undoCommand.Undo();
undoCommand = st.Pop();
undoCommand.Undo();


//Scheduling - pq for scheduling

//Dictionary<ICommand, TimeOnly> schedules = new Dictionary<ICommand, TimeOnly>();
//schedules.Add(new LightOnCommand(l1), new TimeOnly("10:00"));
//schedules.Add(new LightOnCommand(l1), new TimeOnly("10:00"));
//schedules.Add(new LightOnCommand(l1), new TimeOnly("10:00"));






