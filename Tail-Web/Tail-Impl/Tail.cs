﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tail_Spec;

namespace Tail_Impl
{
    public class Tail : ITail
    {
        private bool _isFollowing = false;

        private string _fileName;

        private Action<string> _followCallback;

        public bool IsFollowing => _isFollowing;

        public Tail(string fileName)
        {
            this._fileName = fileName;
        }

        public long Bytes(int start = 0)
        {
            throw new NotImplementedException();
        }

        public void Follow(Action<string> followCallback)
        {
            this._followCallback = followCallback;
            this._isFollowing = true;
            Thread thread = new Thread(startFollow);
            thread.Start();
            //startFollow();
        }

        public void Unfollow()
        {
            this._followCallback = null;
            this._isFollowing = false;
        }

        private void startFollow()
        {
            using (StreamReader reader = new StreamReader(
                            new FileStream(
                                this._fileName,
                                FileMode.Open,
                                FileAccess.Read,
                                FileShare.ReadWrite)))
            {
                //start at the end of the file
                long lastMaxOffset = reader.BaseStream.Length;

                while (_isFollowing)
                {
                    System.Threading.Thread.Sleep(1000);

                    //if the file size has not changed, idle
                    if (reader.BaseStream.Length == lastMaxOffset)
                        continue;

                    //seek to the last max offset
                    reader.BaseStream.Seek(lastMaxOffset, SeekOrigin.Begin);

                    //read out of the file until the EOF
                    string line = "";
                    while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                        //Console.WriteLine(line);
                        this._followCallback?.Invoke(line);

                    //update the last max offset
                    lastMaxOffset = reader.BaseStream.Position;
                }
            }
        }

        public string[] Line(int line = 10)
        {
            throw new NotImplementedException();
        }

        public bool Retry()
        {
            throw new NotImplementedException();
        }

        public void Sleep(int interval = 1000)
        {
            throw new NotImplementedException();
        }
    }
}
