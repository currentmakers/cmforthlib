\
\ @file flash_ctrl.fs
\ @brief 4kb addressable space
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief COMMAND register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000000ff constant FLASH_CTRL_COMMAND_COMMAND                       \ Macro commands for flash operations (may require DATA0...DATA3 to be set): - 0x11 : ERASE - 0x22 : MASSERASE - 0x33 : WRITE - 0x55 : MASSREAD - 0xAA : SLEEP - 0xBB : WAKEUP - 0xCC : BURSTWRITE - 0xEE : OTPWRITE - 0xFF : KEYWRITE


\
\ @brief CONFIG register
\ Address offset: 0x04
\ Reset value: 0x00000010
\

$00000002 constant FLASH_CTRL_CONFIG_REMAP                          \ CPU access routing (it supersedes PREMAP configuration): - 0 : FLASH memory addressed - 1 : SRAM0 memory addressed
$00000004 constant FLASH_CTRL_CONFIG_DIS_GROUP_WRITE                \ Burst write Control: - 0 : burst write allowed - 1 : burst write forbidden
$00000030 constant FLASH_CTRL_CONFIG_WAIT_STATE                     \ Add latency to flash read opeations: - 00 : no latency - 01 : 1 clock cycle latency - 10 : 2 clock cycles latency - 11 : 3 clock cycles latency


\
\ @brief IRQSTAT register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant FLASH_CTRL_IRQSTAT_CMDDONE_MIS                   \ (1: clear, 0: inactive) CMDDONE_MIS flag
$00000002 constant FLASH_CTRL_IRQSTAT_CMDSTART_MIS                  \ (1: clear, 0: inactive) CMDSTART_MIS flag
$00000004 constant FLASH_CTRL_IRQSTAT_CMDBUSYERR_MIS                \ (1: clear, 0: inactive) CMDBUSYERR_MIS flag
$00000008 constant FLASH_CTRL_IRQSTAT_ILLCMD_MIS                    \ (1: clear, 0: inactive) ILLCMD_MIS flag
$00000010 constant FLASH_CTRL_IRQSTAT_READOK_MIS                    \ (1: clear, 0: inactive) READOK_MIS flag
$00000020 constant FLASH_CTRL_IRQSTAT_FNREADY_MIS                   \ (1: clear, 0: inactive) FNREADY_MIS flag


\
\ @brief IRQMASK register
\ Address offset: 0x0C
\ Reset value: 0x0000003F
\

$00000001 constant FLASH_CTRL_IRQMASK_CMDDONEM                      \ (1: mask, 0: inactive) CMDDONE_MIS mask
$00000002 constant FLASH_CTRL_IRQMASK_CMDSTARTM                     \ (1: mask, 0: inactive) CMDSTART_MIS mask
$00000004 constant FLASH_CTRL_IRQMASK_CMDBUSYERRM                   \ (1: mask, 0: inactive) CMDBUSYERR_MIS mask
$00000008 constant FLASH_CTRL_IRQMASK_ILLCMDM                       \ (1: mask, 0: inactive) ILLCMD_MIS mask
$00000010 constant FLASH_CTRL_IRQMASK_READOKM                       \ (1: mask, 0: inactive) READOK_MIS mask
$00000020 constant FLASH_CTRL_IRQMASK_FNREADYM                      \ (1: mask, 0: inactive) FNREADY_MIS mask


\
\ @brief IRQRAW register
\ Address offset: 0x10
\ Reset value: 0x00000001
\

$00000001 constant FLASH_CTRL_IRQRAW_CMDDONE_RIS                    \ (1: active, 0: inactive) COMMAND sequence ended
$00000002 constant FLASH_CTRL_IRQRAW_CMDSTART_RIS                   \ (1: active, 0: inactive) COMMAND sequence started
$00000004 constant FLASH_CTRL_IRQRAW_CMDBUSYERR_RIS                 \ (1: active, 0: inactive) COMMAND issued while flash busy
$00000008 constant FLASH_CTRL_IRQRAW_ILLCMD_RIS                     \ (1: active, 0: inactive) Illegal command issued
$00000010 constant FLASH_CTRL_IRQRAW_READOK_RIS                     \ (1: active, 0: inactive) READ COMMAND completed successfully
$00000020 constant FLASH_CTRL_IRQRAW_CMDSLEEPERR_RIS                \ (1: active, 0: inactive) COMMAND issued while flash in sleep-mode (SLM=1)


\
\ @brief SIZE register
\ Address offset: 0x14
\ Reset value: 0x0006BFFF
\

$0001ffff constant FLASH_CTRL_SIZE_FLASH_SIZE                       \ Maximum valid address for flash memory: - 00 : 0x03FFF (64kb) - 01 : 0x07FFF (128kb) - 10 : 0x09FFF (160kb) - 11 : 0x0BFFF (192kb)
$00020000 constant FLASH_CTRL_SIZE_RAM_SIZE                         \ RAM memory size selection: - 0 : 16kb - 1 : 32kb
$00080000 constant FLASH_CTRL_SIZE_FLASH_SECURE                     \ Flash memory protection (0: no key present, 1: key present)
$00100000 constant FLASH_CTRL_SIZE_JTAG_DISABLE                     \ Flash+JTAG protection (0: no JTAG protection - see FLASH_SECURE, 1: Flash and JTAG protected)
$00600000 constant FLASH_CTRL_SIZE_PACKAGE_SIZE                     \ Package selection: - 0- : CSP - 10 : 32pins - 11 : 48pins


\
\ @brief ADDRESS register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000003f constant FLASH_CTRL_ADDRESS_YADDR                         \ Flash column address offset to be used with some COMMAND
$0000ffc0 constant FLASH_CTRL_ADDRESS_XADDR                         \ Flash row address offset to be used with some COMMAND


\
\ @brief LFSRVAL register
\ Address offset: 0x24
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_LFSRVAL_LFSRVAL                       \ Flash read data CRC signature


\
\ @brief PAGEPROT0 register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000007f constant FLASH_CTRL_PAGEPROT0_SEGSIZE0                    \ First segment, 7-bit page protection size (number of pages to protect in segment, first page included)
$00007f00 constant FLASH_CTRL_PAGEPROT0_SEGOFFSET0                  \ First segment, 7-bit page protection offset (first page number in protected segment)
$007f0000 constant FLASH_CTRL_PAGEPROT0_SEGSIZE1                    \ Second segment, 7-bit page protection size (number of pages to protect in segment, first page included)
$7f000000 constant FLASH_CTRL_PAGEPROT0_SEGOFFSET1                  \ Second segment, 7-bit page protection offset (first page number in protected segment)


\
\ @brief PAGEPROT1 register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000007f constant FLASH_CTRL_PAGEPROT1_SEGSIZE2                    \ Third segment, 7-bit page protection size (number of pages to protect in segment, first page included)
$00007f00 constant FLASH_CTRL_PAGEPROT1_SEGOFFSET2                  \ Third segment, 7-bit page protection offset (first page number in protected segment)
$007f0000 constant FLASH_CTRL_PAGEPROT1_SEGSIZE3                    \ Fourth segment, 7-bit page protection size (number of pages to protect in segment, first page included)
$7f000000 constant FLASH_CTRL_PAGEPROT1_SEGOFFSET3                  \ Fourth segment, 7-bit page protection offset (first page number in protected segment)


\
\ @brief DATA0 register
\ Address offset: 0x40
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_DATA0_DATA0                           \ Value to be used as DATA for any COMMAND of type WRITE and compare value for MASSREAD


\
\ @brief DATA1 register
\ Address offset: 0x44
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_DATA1_DATA1                           \ Value to be used as DATA for any COMMAND of type WRITE


\
\ @brief DATA2 register
\ Address offset: 0x48
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_DATA2_DATA2                           \ Value to be used as DATA for any COMMAND of type WRITE


\
\ @brief DATA3 register
\ Address offset: 0x4C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_CTRL_DATA3_DATA3                           \ Value to be used as DATA for any COMMAND of type WRITE


\
\ @brief 4kb addressable space
\
$40001000 constant FLASH_CTRL_COMMAND  \ offset: 0x00 : COMMAND register
$40001004 constant FLASH_CTRL_CONFIG  \ offset: 0x04 : CONFIG register
$40001008 constant FLASH_CTRL_IRQSTAT  \ offset: 0x08 : IRQSTAT register
$4000100c constant FLASH_CTRL_IRQMASK  \ offset: 0x0C : IRQMASK register
$40001010 constant FLASH_CTRL_IRQRAW  \ offset: 0x10 : IRQRAW register
$40001014 constant FLASH_CTRL_SIZE  \ offset: 0x14 : SIZE register
$40001018 constant FLASH_CTRL_ADDRESS  \ offset: 0x18 : ADDRESS register
$40001024 constant FLASH_CTRL_LFSRVAL  \ offset: 0x24 : LFSRVAL register
$40001034 constant FLASH_CTRL_PAGEPROT0  \ offset: 0x34 : PAGEPROT0 register
$40001038 constant FLASH_CTRL_PAGEPROT1  \ offset: 0x38 : PAGEPROT1 register
$40001040 constant FLASH_CTRL_DATA0  \ offset: 0x40 : DATA0 register
$40001044 constant FLASH_CTRL_DATA1  \ offset: 0x44 : DATA1 register
$40001048 constant FLASH_CTRL_DATA2  \ offset: 0x48 : DATA2 register
$4000104c constant FLASH_CTRL_DATA3  \ offset: 0x4C : DATA3 register

