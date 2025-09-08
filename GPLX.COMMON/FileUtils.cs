using System;
using System.IO;

namespace GPLX.COMMON;

public class FileUtils
{
	public static bool DeleteFile(string sFilePath, ref string sError)
	{
		try
		{
			File.Delete(sFilePath);
			return true;
		}
		catch (Exception ex)
		{
			sError = ex.Message;
			return false;
		}
	}

	public static bool DeleteFile(string sFilePath, string sFileFilter, ref string sError)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(sFilePath);
			FileInfo[] files = directoryInfo.GetFiles(sFileFilter);
			for (int i = 0; i < files.Length; i++)
			{
				files[i].Delete();
			}
			return true;
		}
		catch (Exception ex)
		{
			sError = ex.Message;
			return false;
		}
	}

	public static bool MoveFile(string sFromFile, string sToFile, ref string sError)
	{
		try
		{
			if (File.Exists(sToFile))
			{
				File.Delete(sToFile);
			}
			File.Move(sFromFile, sToFile);
			return true;
		}
		catch (Exception ex)
		{
			sError = ex.Message;
			return false;
		}
	}

	public static bool CopyFile(string sFromFile, string sToFile, ref string sError)
	{
		try
		{
			if (File.Exists(sToFile))
			{
				File.Delete(sToFile);
			}
			File.Copy(sFromFile, sToFile);
			return true;
		}
		catch (Exception ex)
		{
			sError = ex.Message;
			return false;
		}
	}

	public static bool DeleteDirectory(string sFolderPath, ref string sError)
	{
		try
		{
			Directory.Delete(sFolderPath, recursive: true);
			return true;
		}
		catch (Exception ex)
		{
			sError = ex.Message;
			return false;
		}
	}

	public static bool CreateDirectory(string sFolderPath, ref string sError)
	{
		try
		{
			Directory.CreateDirectory(sFolderPath);
			return true;
		}
		catch (Exception ex)
		{
			sError = ex.Message;
			return false;
		}
	}

	public static bool MoveDirectory(string sFromPath, string sToPath, ref string sError)
	{
		try
		{
			Directory.Move(sFromPath, sToPath);
			return true;
		}
		catch (Exception ex)
		{
			sError = ex.Message;
			return false;
		}
	}
}
